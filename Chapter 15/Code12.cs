builder.Services.AddRazorComponents().AddInteractiveServerComponents() // For Interactive Server SSR
.AddInteractiveWebAssemblyComponents(); //For Interactive CSR and Auto
app.MapRazorComponents<App>().AddInteractiveServerRenderMode() // For server interactivity
.AddInteractiveWebAssemblyRenderMode() //For WebAssembly interactivity
.AddInteractiveAutoRenderMode(); // For hybrid prerendering
