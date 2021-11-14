using System;

namespace OpenRelease.Type
{
    public partial class ProjectType
    {
        private readonly string name;
        private readonly Version version;
        private readonly bool @override;

        public ProjectType(string Name, Version Version, bool Override = false)
        {
            name = Name;
            version = Version;
            @override = Override;
        }
    }
}
