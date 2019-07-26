
# AmIAMutant

## Contrived Example to Demonstrate Stryker Ussage for .Net, C#. 

Install Stryker : [https://stryker-mutator.io/stryker-net/](https://stryker-mutator.io/stryker-net/)
Navigate to the test project : *... AmIAMutant\AmIAMutantTests*

### Checkout the first commit to see generated mutants and failures 
Commit Message
> Introduce Mutation Analyser and Basic Tests - Test only three things (Mutant / Not Mutant / Age Based Mutation)

`git checkout 52ee7c10e1d9688372b522333089b06ded53110e`

Run Stryker `dotnet stryker`

### Checkout the second commit to see updated tests and new Stryker outcome
Commit Message
> Run Stryker and Update tests accordingly

`git checkout dc489e94aabf61a8c6001dc9e072b307e2438e0a`

Run Stryker `dotnet stryker`