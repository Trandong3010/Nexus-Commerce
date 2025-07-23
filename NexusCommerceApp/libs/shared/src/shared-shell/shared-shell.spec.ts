import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SharedShell } from './shared-shell';

describe('SharedShell', () => {
  let component: SharedShell;
  let fixture: ComponentFixture<SharedShell>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SharedShell],
    }).compileComponents();

    fixture = TestBed.createComponent(SharedShell);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
