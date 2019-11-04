using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomTroupe
{
    public interface IFactorySpell
    {
        GameObject Make();
    }
}