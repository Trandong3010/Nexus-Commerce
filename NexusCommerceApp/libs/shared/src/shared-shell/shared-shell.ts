import { ChangeDetectionStrategy, Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'lib-shared-shell',
  imports: [CommonModule],
  templateUrl: './shared-shell.html',
  styleUrl: './shared-shell.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SharedShell {}
