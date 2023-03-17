using Godot;
using GodotOnReady.Attributes;

namespace TextDocReferenceRepro;

public partial class MyClass : Control
{
    [OnReadyGet("something")] private Node _obj;
}

public partial class MyClass2
{
    // go to definition and then go to definition on delegate
    public Func<int, int> fn;
    public TimeSpan ts;
}

public partial class MyClass3
{
    private TimeSpan ts;
}
