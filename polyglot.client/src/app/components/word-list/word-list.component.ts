import { Component, Input, OnInit } from '@angular/core';
import { Language, WordItem } from '../../models/QuizItem';

@Component({
  selector: 'app-word-list',
  templateUrl: './word-list.component.html',
  styleUrl: './word-list.component.css'
})
export class WordListComponent implements OnInit{
  words!: WordItem[]

  ngOnInit(): void {
    this.words = [
      {
        word: {
          language: Language.GERMAN,
          polishTranslation: "język",
          translation : "die Sprache"
        },
        id: 1,
        needToBeStudied: false,
        priority : 1
      },
      {
        word: {
          language: Language.GERMAN,
          polishTranslation: "samochód",
          translation: "das Auto"
        },
        id: 2,
        needToBeStudied: false,
        priority: 1
      },
      {
        word: {
          language: Language.GERMAN,
          polishTranslation: "pojazd",
          translation: "der Verkehrsmittel"
        },
        id: 3,
        needToBeStudied: false,
        priority: 1
      },
    ]
  }



}
