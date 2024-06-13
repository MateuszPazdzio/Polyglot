import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { QuizComponent } from './components/quiz/quiz.component';
import { WordListComponent } from './components/word-list/word-list.component';
import { CreateWordComponent } from './components/create-word/create-word.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { EditComponent } from './components/edit/edit.component';
import { WordDetailComponent } from './components/word-detail/word-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    QuizComponent,
    WordListComponent,
    CreateWordComponent,
    HeaderComponent,
    HomeComponent,
    EditComponent,
    WordDetailComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  exports:[],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
