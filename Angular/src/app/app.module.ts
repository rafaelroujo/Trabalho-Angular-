import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule} from '@angular/forms';

import { AngularFirestoreModule } from '@angular/fire/firestore';
import { AngularFireStorageModule } from '@angular/fire/storage';
import { AngularFireAuthModule } from '@angular/fire/auth';
import { AngularFireModule } from '@angular/fire';
import { environment } from '../environments/environment';

import {ConexaoService} from './/services/conexao.service';
import { ListaComponent } from './components/lista/lista.component';
import { ListaAddComponent } from './components/lista-add/lista-add.component';


@NgModule({
  declarations: [
    AppComponent,
    ListaComponent,
    ListaAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebase), 
    AngularFirestoreModule, 
    AngularFireAuthModule, 
    AngularFireStorageModule,
    FormsModule
  ],
  providers: [ConexaoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
