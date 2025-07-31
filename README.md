# WordleClone 2: The Second Coming

The first attempt went up in flames after starting life as an interactive server app but I wanted to take advantage of Azure's free plan for static web apps so I tried converting it to WASM after which I encountered a bug that had haunted quite a few developers in .NET 8 with a critical error in the RenderTree Builder. Even though the app worked just fine, there was a permanent "something went wrong, tap here to reload" bar in the screen.

I ran the upgrade assistant to see what it would take to upgrade to .NET 9: 3 issues and 20 incidents with 20 story points or something along those lines. Might as well create a new project instead of hunting 20+ nuget packages, eh?

## What's different compared to the original Wordle?

I've added a dictionary bar, so you can immediately see that the word that was approved indeed has a definition. I'm still deciding if I want to expand that bar or make it scrollable. It does take up a little too much space and makes it harder for people with accessibility issues to play, perhaps, compared to the original that uses all real estate on a phone.
