# FlashCards for easy and fast learning!

Looking for a digital `FlashCards` that you can run on your computer to learn and memorize stuff? You've come to the right place! Use this `FlashCards` app to memorize any information - including foreign alphabets, words, sentences, mathematical and scientific formulas, and more!
<p align="center"><img src="https://raw.githubusercontent.com/skalavala/FlashCards/master/images/main_window.png"/></p>
This is the main window, where you select the topics. The topics are picked up from the data.json file in the assembly folder.
<br>
<p align="center"><img src="https://raw.githubusercontent.com/skalavala/FlashCards/master/images/flashcard.png" /></p>
This is the FlashCard view, where it either randomly shows flash cards or sequentially. You can then guess the answers by selecting right option. It keeps track of how many you got right and how many you got wrong, and how long it took for you to finish it. What are you waiting for? Download the application and start learning new stuff!<br>
<br>
<p align="center">
<img src="https://raw.githubusercontent.com/skalavala/FlashCards/master/images/edit_topic.png" />
</p>
This is how you can add new elements to the existing topics, and manage the data.
<br>
<p align="center">
<img src="https://raw.githubusercontent.com/skalavala/FlashCards/master/images/edit_topic_data.png" />
</p>

<br>

# Running this program on Microsoft Windows

### Step 1:
You need a Microsoft Windows Operating System with Microsoft .Net installed to run this application. <br> I'd recommend you download the files and try to run it first.

### Step 2: 
Copy the following files [from here](https://github.com/skalavala/FlashCards/tree/master/Output)

* FlashCards.exe (The main program that you run on your computer)
* FlashCards.exe.config (A settings file that tells the program where to look for the data file)
* Newtonsoft.Json.dll (A library that knows how to read the data file)
* data.json (This is the actual data file. You can add/edit the contents, make sure you have a backup first!)

### Step 3: 
Once you downloaded the files, double click on the FashCards.exe file to run.<br>

Feel free to edit `data.json` using your favorite editor, and add/modify content. When you are done, simply restart the program. When you modify the file, make sure there are no issues with the format of the document. To verify, paste the contents of JSON at [https://jsonlint.com/](https://jsonlint.com/) and verify that it is a valid JSON file.
<br><br>

If you have questions, feel free to [contact me](https://github.com/skalavala/FlashCards/issues/new)

# I have Ubuntu. How do I run this on Ubuntu?
You can run this application on Ubuntu, Thanks to [plavelo](https://github.com/plavelo), he showed how to run it on Ubuntu. Follow the steps:

### Step 1: Clone the repo
```
$ git clone https://github.com/skalavala/FlashCards.git
$ cd FlashCards
```
### Step 2: Install Mono
Install mono-complete (buiding & running environment for linux systems)

```
$ sudo apt install mono-complete
```

### Step 3: Build the Project
```
$ xbuild FlashCards.sln
```

### Step 4: Run the Application
```
$ mono Output/FlashCards.exe
```

A BIG thanks to [plavelo](https://github.com/plavelo) for porting this app.
<br>

Enjoy
