import { Output, EventEmitter, Input } from '@angular/core';

export class ButtonComponent {

    @Input() label: string;

    @Output() onClick = new EventEmitter<any>();

    constructor() {}

    onClickButton(event) {

        this.onClick.emit(event);

    }
}