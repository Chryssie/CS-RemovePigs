﻿namespace RemovePigs
{
    public sealed class Settings
    {
        private Settings()
        {
            Tag = "Remove Pigs [Fixed for v1.4+]";
        }

        private static readonly Settings _Instance = new Settings();
        public static Settings Instance { get { return _Instance; } }

        public readonly string Tag;
    }
}