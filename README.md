# Showcase calculator endpoint using RESTful webservice and OpenAPI 3.0.

This solution is based on Clean Architecture approach from early 2020 conferences videos and templates
- [Clean Architecture with ASP.NET Core 3.0 - Jason Taylor - NDC Sydney 2019](https://www.youtube.com/watch?v=5OtUm1BLmG0)
- [Clean Testing: Clean Architecture with .NET Core](https://www.youtube.com/watch?v=2UJ7mAtFuio&t=1560s)

List of files added to the template for calculator endpoint:
- .\src\Application\Calculator\Commands\CalculatorCommand.cs
- .\src\Application\Calculator\Commands\CalculatorCommandValidator.cs
- .\src\Application\Common\Exceptions\DivisionByZeroException.cs
- .\src\Domain\Entities\CalculatorResult.cs
- .\src\Domain\Enums\CalculatorAction.cs
- .\src\Infrastructure\Persistence\Configurations\CalculatorConfiguration.cs
- .\src\WebUI\Controllers\CalculatorController.cs
- .\tests\Applicaton.IntegrationTests\Calculator\CalculatorTests.cs
- .\src\WebUI\ClientApp\src\app\calculator\calculator.component.html
- .\src\WebUI\ClientApp\src\app\calculator\calculator.component.ts
- .\src\WebUI\ClientApp\src\app\calculator\calculator.component.css

Files changed:
- .\src\WebUI\Filters\ApiExceptionFilter.cs
- .\src\WebUI\ClientApp\src\app\app.module.ts
