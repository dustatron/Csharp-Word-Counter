# _Word Counter_

#### _This is a simple console app that will allow a user to check how many times a word appears in a sentence. | March 6th. 2020_

#### By _**Dusty McCord**_

## Description

This console app will allow a user to give a sentence and then a word. The program will then return the amount of times that word appears in the sentance. It will not include if the word can be found in other words. 

[create a .gitignore template for your os here](https://www.gitignore.io/)

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Find the green 'Clone or Download' button and copy the link
2. Open terminal and type...

**Windows**
```sh 
cd desktop
```

 Mac & linux 
 ```sh
 cd ~/Desktop
 ```

 3. In terminal type '_git clone {link to repository}_ '

```sh
git clone https://github.com/dustatron/Csharp-Word-Counter.git
```

4. Navigate to the new folder that was created on your desk

5. Navigate to MakeConsole by tpying:
```sh
cd WordCounter
```
6. Run this command:
```sh
dotnet run
```


## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
User will input a word and the computer will return if word is valid | 'you' | true
User will input a word with a number in it and the computer will return if word is valid | 'you8' | false
User inputs a sentence and the program will return the sentance is Valid | 'Thank you for being a friend' | true
User inputs a sentence with a non-word the program will return the sentance is Valid | 'Thank you for b3ing a friend' | false
The program will remove punctuation, uppercase, and return a normalized sentence | 'Thank you for being a friend!' | 'thank you for being a friend'
User inputs one sentence and one word. The program will return a number showing how many time the word was in the sentence | 'Thank you for being a friend' + 'friend' | 1 time.
User inputs one sentence and one word. The program will return a message if there were any words not found in the english dictionary | 'Thank you for being a friend' | all words are english.


## Support 

_The software is provided as is. It might work as expected - or not. Just don't blame me._


## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.Net Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)


### License

This project is licensed under the MIT License 

Copyright (c) 2020 **_Dusty McCord_**

