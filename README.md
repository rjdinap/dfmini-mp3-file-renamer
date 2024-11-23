# dfmini-mp3-file-renamer
Automatically add and remove numbering to your mp3 files for dfmini applications

If you're here, you probably already know that the dfmini mp3 player allows up to 99 directories of songs, and each directory can have 255 songs. That's a lot of songs. You probably also know that songs need to begin with a 3 digit number. That's a lot of file renaming. This quick and dirty vb.net (vs 2013) application can automatically number, or removing numbering from any .mp3 files in a given directory. (I've seen some versions of dfmini players where it expects 4 digits. I'm using an Umlife version, which works with 3 digit numbers. It may work with 4 digit numbers, I just haven't tried it.)

It will scan for 2 formats:
A filename beginning with "xxx Filename", where xxx is a number. If it sees digits in the first 3 characters of a filename, it will remove the first 3 characters of the filename as part of the renumbering.
A filename beginning with "xxx - yyy Filename" where xxx and yyy are numbers. If it see digits in positions 1-3 and then again in 7-9, it will remove the first 9 characters as part of the renumbering.

If you choose the radio button to remove numbering and then press start, it will remove numbering from all of your .mp3 files.

If you choose the radio button to add numbering and then press start, it add numbering in the following format: "xxx - yyy Filename", where xxx is the physical number of the mp3 file in the directory, and yyy is a 2nd number that starts with the number 100 and increments for each song. (This was written to assist with implementation in a physical jukebox where song numbers range from 100 - 299). A quick edit to one line of code if you don't want the 2nd number in your filename. You don't need to remove numbering before adding numbering again, it will handle it automically.

If choosing the 'add numbering' button, internally, it first removes all numbers from the beginning of filesnames. It then sorts all the filenames in alphabetical order. And then it adds the new numbering.

If you don't have visual studio, or you don't want to compile, there is a pre compiled .exe in the /bin/debug folder of the repository.


![image](https://github.com/user-attachments/assets/8a9988c6-efbd-46dd-8fea-d35bb4260ca9)
