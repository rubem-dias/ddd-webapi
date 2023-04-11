## CORS
> i need to add on request header the Access-Control-Allow-Origin: (url).\
for example:

```
builder.Services.AddCors( opt => {
    opt.AddPolicy("CorsPolicy", polcy => {
        polcy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});

```
creating with this code, a service acepting cors in this FRONT-END URL
> after that.\

```
app.UseCors("CorsPolicy");

```
passing the same <b>CorsPolicy</b> from Services.AddCors to <b>app.UseCors</b>;

## SEMANTIC UI

```
npm install semantic-ui-react semantic-ui-css
```
and add css references
```
import 'semantic-ui-css/semantic.min.css'
```