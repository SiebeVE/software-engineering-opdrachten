using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
  public class TeerlingModel
  {
    private int _aantalOgen; // aantal ogen per teerling
    private bool vast;
    private bool toonWerp = false;

    public int Aantalogen //mogelijk maken dat andere aantal ogen teerling aanpassen
    {
      get
      {
        return _aantalOgen;
      }
      set
      {
        _aantalOgen = value;
      }
    }
    public bool Vast
    {
      get
      {
        return vast;
      }
      set
      {
        vast = value;
      }
    }

    public bool ToonWerp
    {
      get
      {
        return toonWerp;
      }
      set
      {
        toonWerp = value;
      }
    }
  }
}