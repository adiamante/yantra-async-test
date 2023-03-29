
using YantraJS.Core;

var synchronizationContext = new SynchronizationContext();
var context = new JSContext(synchronizationContext);
await context.ExecuteAsync("const sleep = ms => new Promise(r => setTimeout(r, ms));");
await context.ExecuteAsync("await sleep(1000);");

var x = 1;