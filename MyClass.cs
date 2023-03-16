using Godot;
using GodotOnReady.Attributes;

namespace TextDocReferenceRepro;

public partial class MyClass : Control
{
    [OnReadyGet("something")] private Node _obj;
}

public partial class MyClass2
{
    public TimeSpan ts;
}

public partial class MyClass3
{
    private TimeSpan ts;
}
