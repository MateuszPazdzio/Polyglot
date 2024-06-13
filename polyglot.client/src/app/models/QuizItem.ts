export interface QuizItem {
  word : Word
  guessed: boolean,
  attempt: number,
  //attempt boundry
  //level of complication
}
type Word = {
  polishTranslation: string,
  language: Language,
  translation: string,
}
export interface WordItem{
  id:number,
  word: Word;
  priority: number
  needToBeStudied:boolean
  //need to be learned
  //set priority
}

export enum Language {
  GERMAN = 1,
  SPANISH = 2
}
