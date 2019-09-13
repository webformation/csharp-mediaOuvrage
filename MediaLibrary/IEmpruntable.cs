using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    interface IEmpruntable
    {
        bool IsDisponible();
        bool Emprunter();
        bool Rendre();
    }
}
