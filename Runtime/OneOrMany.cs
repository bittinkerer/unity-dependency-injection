using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Packages.Esteny.Providers
{
  [Serializable]
  internal class OneOrMany<T> : IEnumerable<T>
  {
    private T[] _values;

    public OneOrMany(IEnumerable<T> values)
    {
      if (values == null)
      {
        _values = new T[0];
      }
      else
      {
        _values = values.ToArray();
      }
    }

    public IEnumerator<T> GetEnumerator() =>
      ((IEnumerable<T>)_values).GetEnumerator();
    
    IEnumerator IEnumerable.GetEnumerator() =>
      _values.GetEnumerator();

    // syntactic sugar
    public static implicit operator T(OneOrMany<T> values) => values.FirstOrDefault();
    public static implicit operator T[](OneOrMany<T> values) => values._values;
  }
}