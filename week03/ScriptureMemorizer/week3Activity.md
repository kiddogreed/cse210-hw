I was able to join group meeting and actively participating in sharing ideas regards the week03 activity.


Class Diagram

Scripture
  * _reference : Reference
  * _words: List<Word>

Scripture(Reference:Reference, text:string)

HideRandomWords(numberToHide: int):void
GetDisplayText():string
IsCompletelyHidden():bool



Reference
  *_book:string
  *_chapter:int
  *_verse:int
  *_endVerse:int

Reference(book: string,chapter:int, verse:int)
Reference(book:string,chapter:int,startverse:int, endVerse:int)

GetDisplayText(): string


Word
  *_text:string
  *_isHidden:bool

Word(text:string)

Hide():void
Show():void
isHidden():bool
GetDisplayText():string

