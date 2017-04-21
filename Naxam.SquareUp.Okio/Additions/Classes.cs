using System;
using Java.Lang;

namespace Okio
{
    public partial class ByteString
    {
        public int CompareTo(Java.Lang.Object obj) {
            return CompareTo(obj as ByteString);
        }
    }

    public partial class Options {
        public override Java.Lang.Object Get(int index) {
            return GetByteString(index);
        }
    }
}
