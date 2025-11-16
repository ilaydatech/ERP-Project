import { BlankComponent } from '../components/blank/blank.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { SectionComponent } from '../components/section/section.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BlankComponent,
    SectionComponent,
    FormsModule
  ],
  exports: [
    CommonModule,
    BlankComponent,
    SectionComponent,
    FormsModule
  ]
})
export class SharedModule { }
