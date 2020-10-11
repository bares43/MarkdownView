# Markdown *for Xamarin.Forms* 

[![NuGet](https://img.shields.io/nuget/v/Xam.Forms.Markdown.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Forms.Markdown/) [![Donate](https://img.shields.io/badge/donate-Buy%20Me%20a%20Coffe-%235F7FFF)](https://www.buymeacoffee.com/bares43)<br />
You can also support author of original package here [![Donate](https://img.shields.io/badge/donate-paypal-yellow.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=ZJZKXPPGBKKAY&lc=US&item_name=GitHub&item_number=0000001&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted)

A native Xamarin.Forms Markdown renderer.

Fork of original repository https://github.com/dotnet-ad/MarkdownView with some improvements.

## Gallery

![Light theme](Documentation/Screenshot.png)

## Introduction

Compared to a majority of solutions, MarkdownView will render every component as **a native Xamarin.Forms view instead of via an HTML backend.** The Markdown is directly translated from a syntax tree to a hierarchy of Xamarin.Forms views, : no HTML is being produced at all (hurray)!

This will produce a more reactive user interface, at the cost of rendering functionalities *(at the moment though!)*.

## Install

Available on [NuGet](https://www.nuget.org/packages/Xam.Forms.Markdown/).

## Quickstart

```csharp
var view = new MarkdownView();
view.Markdown = "# Hello world\n\nThis is my first native markdown rendering";
view.Theme = new DarkMarkdownTheme(); // Default is white, you also modify various values
this.Content = view;
```

## Limitations

Unfortunately, Xamarin.Forms string rendering has some limitations ...

* **Inlined images aren't supported** (*Xamarin.Forms formatted strings doesn't support inlined views*) : They will be displayed after the block they are referenced from.
* **Links are only clickable at a leaf block level**  (*Xamarin.Forms formatted strings doesn't support span user interactions*) : if a leaf block contains more than one link, the user is prompted. This is almost a feature since text may be too small to be enough precise! ;)
* **SVG rendering is very limited** (*The SVG rendering is based on SkiaSharp which doesn't seem to manage well all svg renderings*)

## Roadmap

* **Customization**
	* [X] Styles 
	* [X] Themes 
* **Leaf blocks**
	* [X] Headings
	* [X] Paragraphs
	* [ ] HTML Blocks (maybe partial and specific support)
	* [ ] Link reference definitions
	* [X] Code blocks
	* [X] Thematic breaks
* **Container blocks**
	* [X] Block quote
	* [X] Lists
		* [ ] Numbers bullet formats
		* [ ] Custom bullets
* **Inlines**
	* [X] Textual content
	* [X] Emphasis and string emphasis
	* [X] Code spans
	* [X] Links (partial, no interaction)
	* [X] Image blocks (partial, not inlined)
		* [X] SVG Rendering (Skia)
* **Extensions**
	* [ ] Table blocks
	* [ ] Emojis (ascii)
	* [ ] Task lists 

## Thanks

* [dotnet-ad/MarkdownView](https://github.com/dotnet-ad/MarkdownView) : original package
* [lunet-io/markdig](https://github.com/lunet-io/markdig) : used for Markdown parsing
* [mono/SkiaSharp](https://github.com/mono/SkiaSharp) : used for SVG rendering

## Contributions

Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

## License

MIT © [bares43](https://janbares.cz/en/), [Aloïs Deniel](http://aloisdeniel.github.io)
