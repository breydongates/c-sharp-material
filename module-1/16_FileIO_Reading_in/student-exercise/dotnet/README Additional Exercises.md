# File I/O Part 1 Additioanl OPTIONAL Exercises

## Word Count

Write a program that asks for a filesystem path for a text file and reads the contents of the file. After processing the file, it displays both the number of words and the number of sentences in the file.

Hints: 
- Words are delimited by space characters.
- Sentences are terminated by either a period, an exclamation mark, or a question mark.

Use `alices_adventures_in_wonderland.txt` for test input.

The output should be:
```
Word Count: 30355
Sentence Count: 1116*
```
**Sentence Count may vary between 1116 - 1839.*


### QuizMaker (Challenge)

Create a quiz maker program that asks the user a question. The user should be presented with multiple choice answers and be allowed to specify the correct answer.

The program should read the questions from an input file during startup. The questions and answers in the file are pipe-delimited ("|") and correct answers are marked with an asterisk ("*") in the file.

For example:
```
Question-1|answer-1|answer-2|correct-answer*|answer-4
```

An example of the file might look something like this:
```
What color is the sky?|Yellow|Blue*|Green|Red
What are Cleveland's odds of winning a championship?|Not likely*|Highly likely|Fat chance|Who cares??
```

The application is started with the command `dotnet run --project QuizMaker/QuizMaker.csproj`.

**Tips**

* Create a class that can hold a quiz question, its available answers, and the correct answer.
* Try holding each quiz question in a list of quiz questions.

#### Part 1

Ask a single question to the user when the application is opened. Don't show the asterisk in the list of choices.

Example
```
Enter the fully qualified name of the file to read in for quiz questions
[path-to-quiz-file]
What color is the sky?
1. Yellow
2. Blue
3. Green
4. Red

Your answer: 2
RIGHT!
```

#### Part 2

Go through all of the available quiz questions and ask the user each one sequentially. Record how many answers they got correct and print out the total at the end.

Example
```
What color is the sky?
1. Yellow
2. Blue
3. Green
4. Red

Your answer: 1
WRONG!

What are the Cleveland Browns' odds of winning a championship?
1. Not likely
2. Highly likely
3. Fat chance
4. Who cares??

Your answer: 1
RIGHT!

You got 1 answer(s) correct out of the 2 questions asked.
```
