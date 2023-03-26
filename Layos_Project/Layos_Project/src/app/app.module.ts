import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { HeaderComponent } from './component/header/header.component';
import { MainComponent } from './component/main/main.component';
import { FearlessComponent } from './component/fearless/fearless.component';
import { SpeaknowComponent } from './component/speaknow/speaknow.component';
import { Red1989Component } from './component/red1989/red1989.component';
import { ReploverComponent } from './component/replover/replover.component';
import { FolkmoreComponent } from './component/folkmore/folkmore.component';
import { DebComponent } from './component/deb/deb.component';
import { MidComponent } from './component/mid/mid.component';
import { InfoComponent } from './component/info/info.component';
import { PackageComponent } from './component/package/package.component';


@NgModule({
  declarations: [
    HeaderComponent,
    InfoComponent,
    MainComponent,
    FearlessComponent,
    SpeaknowComponent,
    Red1989Component,
    ReploverComponent,
    FolkmoreComponent,
    DebComponent,
    MidComponent,
    PackageComponent,
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule 
  ],
  providers: [],
  bootstrap: [
    HeaderComponent,
    InfoComponent,
    MainComponent,
    FearlessComponent,
    SpeaknowComponent,
    Red1989Component,
    ReploverComponent,
    FolkmoreComponent,
    DebComponent,
    MidComponent,
    PackageComponent,]
})
export class AppModule { }
