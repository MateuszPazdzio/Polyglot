import { Component, Input } from '@angular/core';
import { WordItem } from '../../models/QuizItem';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-word-detail',
  templateUrl: './word-detail.component.html',
  styleUrl: './word-detail.component.css'
})
export class WordDetailComponent {

  @Input()
  detail!: WordItem

  constructor(private http: HttpClient) {

  }

  changeStudyStatus(id: number) {
    (this.detail.needToBeStudied) ? this.detail.needToBeStudied = false : this.detail.needToBeStudied = true
    this.http.post(`https://localhost:7155/Dictionary/UpdateStudyStatus/${id}`, this.detail.needToBeStudied).subscribe(
      (response) => {
        // Handle successful response
        console.log('POST request successful:', response);
      },
      (error) => {
        // Handle error
        console.error('Error making POST request:', error);
      }
    );
  }
}
