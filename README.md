# Showcase calculator endpoint using RESTful webservice and OpenAPI 3.0.

This solution is based on Clean Architecture approach from early 2020 conferences videos and templates
- [Clean Architecture with ASP.NET Core 3.0 - Jason Taylor - NDC Sydney 2019](https://www.youtube.com/watch?v=5OtUm1BLmG0)
- [Clean Testing: Clean Architecture with .NET Core](https://www.youtube.com/watch?v=2UJ7mAtFuio&t=1560s)

List of files added to the template for calculator endpoint:
- C:\Dev\Calculator\src\Application\Calculator\Commands\CalculatorCommand.cs
- C:\Dev\Calculator\src\Application\Calculator\Commands\CalculatorCommandValidator.cs
- C:\Dev\Calculator\src\Application\Common\Exceptions\DivisionByZeroException.cs
- C:\Dev\Calculator\src\Domain\Entities\CalculatorResult.cs
- C:\Dev\Calculator\src\Domain\Enums\CalculatorAction.cs
- C:\Dev\Calculator\src\Infrastructure\Persistence\Configurations\CalculatorConfiguration.cs
- C:\Dev\Calculator\src\WebUI\Controllers\CalculatorController.cs
- C:\Dev\Calculator\tests\Applicaton.IntegrationTests\Calculator\CalculatorTests.cs

Files changed:
- C:\Dev\Calculator\src\WebUI\Filters\ApiExceptionFilter.cs
