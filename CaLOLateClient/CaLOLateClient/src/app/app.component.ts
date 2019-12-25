import { Component } from '@angular/core';
import { MAT_LABEL_GLOBAL_OPTIONS } from '@angular/material/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material';
import { DialogData } from './DialogData';
import { ModalComponent } from './modal/modal.component';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']

})
export class AppComponent {
  title = 'CaLOLateClient';
  imageOfItem: string;
  name: string;

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(ModalComponent, {
      width: '250px',
      data: {name: this.name, imageOfItem: this.imageOfItem}
    });

    dialogRef.afterClosed().subscribe(result => {
      this.imageOfItem = result;
    });
  }
}