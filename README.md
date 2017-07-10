# Refactoring To Patterns
A place to practice Refactoring To Patterns that Kerievsky wrote about in his book.

This repo contains source code that very closely or exactly matches that which is found in Joshua Kerievsky's book [Refactoring to Patterns](https://www.amazon.com/Refactoring-Patterns-Joshua-Kerievsky/dp/0321213351).

# Getting Around

## Language && IDE Concerns
All code samples are written in C#, and therefor will follow C# coding conventions (versus any Java coding conventions you might see in the book).

I have tested running this code in the following IDE's, and all seems to work fine:
* [Visual Studio 2015 (on Windows)](https://www.visualstudio.com/vs/older-downloads/)
* [Visual Studio Community 2017 (for Mac)](https://www.visualstudio.com/vs/visual-studio-mac/)
* [Rider EAP versions (on Windows)](https://www.jetbrains.com/rider/)

There might be an issue with Visual Studio 2017 (on Windows), but I've not been able to dig into it as of yet.

## Projects
Each refactoring that he walks through has it's own project. For example, you will notice that there is a project titled "ReplaceConstructorsWithCreationMethods". This project corresponds to code he offers up on p. 57 in his section titled "Replace Constructors with Creation Methods"

### IntialCode folder
You will also notice that within the "ReplaceConstructorsWithCreationMethods" there is a folder titled "InitialCode". This folder is intended to contain working code that demonstrates the problem as he initially presents it in the book.

### MyWork folder
There is also a folder titled "MyWork". This folder initially carries an exact copy of what's in the "InitialCode" folder. However, the intention of the "MyWork" folder is that it is a place for you to experiment with in implementing the refactoring. In this way, once you have implemented the refactoring, you have the ability to look at both the initial problem and the refactored solution and weigh the benefits of one pattern (or lack thereof) and the code refactored to or towards a pattern.

## RefactoringToPatterns.Tests Project

This project also contains sections for each refactoring, but it differs from what I meantioned before in that it has unit tests that in
some way excercise the code found in the implemented code project.

For example, if you look in the RefactoringToPatterns.Tests project you will see a section for "ReplaceConstructorsWithCreationMethods". This should sound familiar as I mentioned it before. This section of the tests project also has an "InitialCode" section and a "MyWork" section. Each of these sections contains unit tests linking out to the actual implmentations. Like before, your "MyWork" section is a place for you to experiment with as you move through the refactoring as it's discussed in the book.

## Conclusion

Take a look around. If anything doesn't make sense once you peek at it, please just create an Issue here in GitHub where we
can discuss it. Like any system, if you want to understand how it works, go look at the tests as they are a great durrable source of low level documentation.
