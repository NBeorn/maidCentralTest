import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  CalculationDto,
  CalculatorServiceProxy,
  CreateStartingValuesDto,
  GetAllStartingValues,
  StartingValuesDto
} from '@shared/service-proxies/service-proxies';
import { AppSessionService } from '@shared/session/app-session.service';
import { start } from 'repl';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css'],
  animations: [appModuleAnimation()]
})
export class CalculatorComponent extends AppComponentBase implements OnInit {
  startingValues: StartingValuesDto[];
  calculations: CalculationDto[];

  constructor(
    injector: Injector, 
    private _calculatorService: CalculatorServiceProxy, 
    private _sessionService: AppSessionService,
    ) {
      super(injector);
  }

  ngOnInit() {
    this.refresh();
  }

  refresh() {
    this._calculatorService
      .getAll()
      .subscribe(result => {
        this.startingValues = result.items;
        this.calculate(result.items);
      });
  }

  setStartingValue(title: string, value: number) {
    if (this.startingValues.find(x => x.name == title)) {
      const startingValue = new StartingValuesDto();
      startingValue.name = title;
      startingValue.value = value;
      startingValue.id = this.startingValues.find(x => x.name == title).id;
      
      this._calculatorService
        .update(startingValue)
        .subscribe(
          () => {
            this.notify.info(this.l('SavedSuccessfully'));
            this.refresh();
          }
        )
    } else {
      const startingValue = new CreateStartingValuesDto();
      startingValue.name = title;
      startingValue.value = value;
      startingValue.creatorUserId = this._sessionService.userId;

      this._calculatorService
        .create(startingValue)
        .subscribe(
          () => {
            this.notify.info(this.l('SavedSuccessfully'));
          }
        );
    }    
  }

  getValue(title: string) {
    if (this.startingValues) {
      return this.startingValues?.filter(x => x.name == title)[0].value;
    }
    
    return 0;
  }

  calculate(startingItems: StartingValuesDto[]) {
    this._calculatorService
      .calculate(startingItems)
      .subscribe(result => {
        this.calculations = result.items;
      })
  }

  getCalculation(title: string) {
    return this.calculations?.find(x => x.name == title).value;
  }
}
