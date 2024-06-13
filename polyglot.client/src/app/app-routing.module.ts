import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CreateWordComponent } from './components/create-word/create-word.component';
import { WordListComponent } from './components/word-list/word-list.component';
import { EditComponent } from './components/edit/edit.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "create", component: CreateWordComponent },
  { path: "words", component: WordListComponent },
  { path: "edit/:id", component: EditComponent },
  { path: "delete/:id", component: EditComponent },
  //{ path: "create", component: CreateCarComponent },
  //{ path: "cars", component: CarlistComponent },
  //{ path: "car/edit/:id", component: EditCarComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
