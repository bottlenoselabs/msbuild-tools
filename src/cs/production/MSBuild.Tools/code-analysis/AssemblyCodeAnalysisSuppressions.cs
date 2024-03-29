// <auto-generated/>
// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
	"Microsoft.Design",
	"CA1050",
	MessageId = "Declare types in namespaces",
	Justification = "To namespace or not to namespace is a developer descision on a case-by-case basis; there should be no blanket rule that says all folders or containers of organization for code should have their own namespace.")]

[assembly: SuppressMessage(
	"Microsoft.Design", 
	"CA1051", 
	MessageId = "Do not declare visible instance fields", 
	Justification = "The idea that 'fields should be as an implementation detail' is wrong; fields are data and developers need to work with data.")]

[assembly: SuppressMessage(
	"Microsoft.Design",
	"CA1062",
	MessageId = "Validate arguments of public methods (null)",
	Justification = "Always use C# nullables which makes this rule redundant and noisy.")]

[assembly: SuppressMessage(
	"Microsoft.Naming", 
	"CA1711",
	MessageId = "Identifiers should not have incorrect suffix",
	Justification = "Naming of types with a certain suffix like 'Exception' or 'Collection' should not reserved just for Microsoft; developers should be free to name types as they wish.")]

[assembly: SuppressMessage(
	"Microsoft.Naming",
	"CA1716",
	MessageId = "Identifiers should not match keywords",
	Justification = "If a developer named something that matches an identifier or keyword it's a conscience and deliberate choice.")]

[assembly: SuppressMessage(
	"Microsoft.Naming", 
	"CA1720", 
	MessageId = "Identifier contains type name",
	Justification = "Developers should know the difference between a builtin type and an identifier on a type with the same name.")]

[assembly: SuppressMessage(
	"Microsoft.Performance",
	"CA1822",
	MessageId = "Mark members as static",
	Justification = "If something could be static but it's not then the developer made a and deliberate choice.")]

[assembly: SuppressMessage(
	"Microsoft.Security",
	"CA5392",
	MessageId = "Use DefaultDllImportSearchPaths attribute for P/Invokes.",
	Justification = "Always ensure the full path is specified, see: https://msrc-blog.microsoft.com/2014/05/13/load-library-safely/. Also, this warning only applies to Windows but macOS and Linux see the thing still, quite annoying.")]

[assembly: SuppressMessage(
	"Microsoft.Globalization",
	"CA1303",
	MessageId = "Do not pass literals as localized parameters (localization).",
	Justification = "Localization of strings should be carefully considered by the developer. ALso, not all applications require localization.")]
	