using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enum
{
    [Flags]
    public enum PerfilEnum
    {
        [Description("Admin")]
        Administrador = 0,
        [Description("Usuário")]
        User = 1
    }
}
