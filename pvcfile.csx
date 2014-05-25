pvc.Task("nuget-push", () => {
    pvc.Source("src/Pvc.$$pluginName$$.csproj")
       .Pipe(new PvcNuGetPack(
            createSymbolsPackage: true
       ))
       .Pipe(new PvcNuGetPush());
});
