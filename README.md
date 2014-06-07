Universals
==========
Language-specific implementations of universal libraries in .NET and Swift

Until [SharpSwift](https://github.com/matthewsot/SharpSwift) can support far more complex parts of the .NET framework many common, but still complicated, things (like downloading a website's HTML code) will have to be written once in C# and once in Swift. Universals will make this easier by providing what is essentially the same interface/abstraction layer across C# and Swift to access different underlying code. You reference the C# version of a Universal in your C# code, then, after converting the syntax to Swift, you link the converted Swift file to the Swift version of the Universal and it should work without a hitch.


Universals are located as separate folders within the /Universals folder. Each Universal is split into two sub-folders: C# and Swift. The C# folder holds a C# project for that Universal, while the Swift folder holds a Swift project for that Universal.