using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DK.Systems.Pooling
{
    public delegate void ReturnOnDestroy();

    public interface IPoolable
    {
        ReturnOnDestroy action { get; set; }

        void Reset();

        void OnCreate();

        void OnDestroy();
    }
}
