using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLesson1.Core
{
    public interface ICloneable<T> where T: ICloneable<T>
    {
        T Clone();
    }
}
