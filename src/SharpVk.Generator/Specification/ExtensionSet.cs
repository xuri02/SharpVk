﻿using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class ExtensionSet
        : IWorker
    {
        private IVkXmlCache xmlCache;
        private Lazy<IEnumerable<string>> knownExtensions;

        public ExtensionSet(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;

            this.knownExtensions = new Lazy<IEnumerable<string>>(this.GetKnownExtensions);
        }

        private IEnumerable<string> GetKnownExtensions()
        {
            var result = new List<string>();

            foreach (var vkExtension in this.xmlCache.GetVkXml()
                                                        .Element("registry")
                                                        .Element("extensions")
                                                        .Elements("extension"))
            {
                string name = vkExtension.Attribute("name").Value;

                var nameParts = name.Split('_');

                string extensionSuffix = nameParts[1].ToLower();

                if (!result.Contains(extensionSuffix))
                {
                    result.Add(extensionSuffix);
                }
            }

            return result;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var vkExtension in this.xmlCache.GetVkXml()
                                                        .Element("registry")
                                                        .Element("extensions")
                                                        .Elements("extension"))
            {
                string name = vkExtension.Attribute("name").Value;

                var nameParts = name.Split('_');

                if (vkExtension.Attribute("supported").Value == "vulkan")
                {
                    string extensionSuffix = nameParts[1].ToLower();

                    var enums = vkExtension.Elements("require").SelectMany(x => x.Elements("enum"));

                    var specVersionElement = enums.Single(x => x.Attribute("name").Value.EndsWith("SPEC_VERSION"));

                    int specVersion = int.Parse(specVersionElement.Attribute("value").Value);

                    services.AddSingleton(new ExtensionInfo
                    {
                        Name = name,
                        SpecVersion = specVersion,
                        Extension = extensionSuffix
                    });
                }
            }
        }

        public IEnumerable<string> KnownExtensions => this.knownExtensions.Value;
    }
}
