using Exiled.API.Interfaces;

namespace СolaKills
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public float Damage { get; set; } = 0.5f;
    }
}
