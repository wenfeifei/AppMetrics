﻿// <copyright file="TimerConverter.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using App.Metrics.Timer;
using Newtonsoft.Json;

namespace App.Metrics.Formatters.Json.Converters
{
    public class TimerConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) { return typeof(TimerValueSource) == objectType; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var source = serializer.Deserialize<TimerMetric>(reader);

            return source.FromSerializableMetric();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var source = (TimerValueSource)value;

            var target = source.ToSerializableMetric();

            serializer.Serialize(writer, target);
        }
    }
}