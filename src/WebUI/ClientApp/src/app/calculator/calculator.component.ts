import { Component } from '@angular/core';
import { CalculatorClient, CalculatorCommand, CalculatorResult, CalculatorAction } from '../calculator-api';

@Component({
  selector: 'app-calculator-component',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  private _client: CalculatorClient;
  private _command = new CalculatorCommand();
  private _result = new CalculatorResult();

  public actions = CalculatorAction;
  public keys = [];

  public calculatorEditor: any = {};

  constructor(private client: CalculatorClient) {
    this._client = client;
    this.calculatorEditor.result = 0;
    this.keys = Object.keys(this.actions).filter(a => !isNaN(Number(a)));
  }

  calculateResult() {
    if (this.calculatorEditor.num1 && this.calculatorEditor.selectedAction && this.calculatorEditor.num2) {
      this._command.num1 = parseFloat(this.calculatorEditor.num1);
      this._command.action = parseInt(this.calculatorEditor.selectedAction);
      this._command.num2 = parseFloat(this.calculatorEditor.num2);

      console.log(this._command);

      this._client.calculate(this._command).subscribe(response => {
        this._result = response;

        console.log(response);

        if (this._result) {
          this.calculatorEditor.result = this._result.result;
        }
      }, error => console.error(error));
    }
  }
}
