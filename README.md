# GuidGenerator

This code is taken from jhtodd/SequentialGuid 
https://github.com/jhtodd/SequentialGuid

There is a blog about it:
https://www.codeproject.com/Articles/388157/GUIDs-as-fast-primary-keys-under-multiple-database

I create this repository to make it available on nuget.

``` C#
var generator = new SequentialGuidGenerator();
var guid = generator.Create(SequentialGuidType.SequentialAtEnd);
```

``` C#
/// <summary>
    /// Describes the type of a sequential GUID value.
    /// </summary>
    public enum SequentialGuidType
    {
        /// <summary>
        /// The GUID should be sequential when formatted using the <see cref="Guid.ToString()" /> method.
        /// Used by MySql and PostgreSql.
        /// </summary>
        SequentialAsString,

        /// <summary>
        /// The GUID should be sequential when formatted using the <see cref="Guid.ToByteArray" /> method.
        /// Used by Oracle.
        /// </summary>
        SequentialAsBinary,

        /// <summary>
        /// The sequential portion of the GUID should be located at the end of the Data4 block.
        /// Used by SqlServer.
        /// </summary>
        SequentialAtEnd
    }
```
