// Copyright (C) 2017 Dmitry Yakimenko (detunized@gmail.com).
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace OnePassword
{
    public class JsonHttpClient
    {
        public JsonHttpClient(IHttpClient http)
        {
            _http = http;
        }

        public JObject Get(string[] url)
        {
            return Get(url, new Dictionary<string, string>());
        }

        public JObject Get(string[] url, Dictionary<string, string> headers)
        {
            // TODO: Escape url components
            return Get(string.Join("/", url), headers);
        }

        public JObject Get(string url)
        {
            return Get(url, new Dictionary<string, string>());
        }

        public JObject Get(string url, Dictionary<string, string> headers)
        {
            return JObject.Parse(_http.Get(url, headers));
        }

        public T Get<T>(string url, Func<JObject, T> parse)
        {
            return Get(url, new Dictionary<string, string>(), parse);
        }

        public T Get<T>(string url,
                        Dictionary<string, string> headers,
                        Func<JObject, T> parse)
        {
            return parse(Get(url, headers));
        }

        private readonly IHttpClient _http;
    }
}
