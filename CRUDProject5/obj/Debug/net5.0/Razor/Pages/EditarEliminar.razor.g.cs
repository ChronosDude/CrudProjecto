#pragma checksum "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e9ce6def4b39d15bb5fc78965f6c740a72355a"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDProject5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using CRUDProject5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\_Imports.razor"
using CRUDProject5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
using CRUDProject5.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editdelete/{Id:int}")]
    public partial class EditarEliminar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddAttribute(1, "class", "flex-shrink-0");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "py-5");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container px-5");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "bg-light rounded-3 py-5 px-4 px-md-5 mb-5");
            __builder.AddMarkupContent(8, @"<div class=""text-center mb-5""><div class=""feature bg-primary bg-gradient text-white rounded-3 mb-3""><i class=""bi bi-pencil-square""></i></div>
                    <h1 class=""fw-bolder"">Actualizar/Eliminar Reporte</h1>
                    <p class=""lead fw-normal text-muted mb-0"">Ingresa los datos solicitados</p></div>
                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row gx-5 justify-content-center");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-8 col-xl-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 39 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                         ObRep

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                            \r\n                            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-floating mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                              ObRep.Asunto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.Asunto = __value, ObRep.Asunto))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ObRep.Asunto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __builder2.AddMarkupContent(29, "<label for=\"name\">Asunto</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                            \r\n                            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-floating mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                  ObRep.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.Descripcion = __value, ObRep.Descripcion))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ObRep.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                                ");
                __builder2.AddMarkupContent(39, "<label for=\"message\">Redacta tu reporte</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n                            \r\n                            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-floating mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                              ObRep.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.Ubicacion = __value, ObRep.Ubicacion))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ObRep.Ubicacion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.AddMarkupContent(49, "<label for=\"phone\">Ubicaci??n</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "card");
                __builder2.AddAttribute(53, "style", "width:30rem;");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "card-body");
                __builder2.OpenElement(56, "img");
                __builder2.AddAttribute(57, "class", "rounded mx-1");
                __builder2.AddAttribute(58, "src", 
#nullable restore
#line 62 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                    ObRep.ImageUbicaton

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-floating mb-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(62);
                __builder2.AddAttribute(63, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                     OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(64, "multiple", true);
                __builder2.AddAttribute(65, "id", "foto");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                                ");
                __builder2.AddMarkupContent(68, "<label for=\"foto\">Sube tu foto</label>");
                __builder2.CloseElement();
#nullable restore
#line 72 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                             if (imageDateUrls.Count > 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "card");
                __builder2.AddAttribute(71, "style", "width:30rem;");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "card-body");
#nullable restore
#line 76 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                         foreach (var imageDataUrl in imageDateUrls)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(74, "img");
                __builder2.AddAttribute(75, "class", "rounded mx-1");
                __builder2.AddAttribute(76, "src", 
#nullable restore
#line 78 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                            imageDataUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 79 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 83 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(77, "<div id=\"getmapbyid\" style=\"height:500px;width:100%;\"></div>\r\n\r\n                            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "hidden");
                __builder2.AddAttribute(80, "class", "form-floating mb-3");
                __Blazor.CRUDProject5.Pages.EditarEliminar.TypeInference.CreateInputNumber_0(__builder2, 81, 82, "latitud", 83, "form-control", 84, 
#nullable restore
#line 89 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                             ObRep.Latitud

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.Latitud = __value, ObRep.Latitud)), 86, () => ObRep.Latitud);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "hidden");
                __builder2.AddAttribute(90, "class", "form-floating mb-3");
                __Blazor.CRUDProject5.Pages.EditarEliminar.TypeInference.CreateInputNumber_1(__builder2, 91, 92, "longitud", 93, "form-control", 94, 
#nullable restore
#line 93 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                              ObRep.Longitud

#line default
#line hidden
#nullable disable
                , 95, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.Longitud = __value, ObRep.Longitud)), 96, () => ObRep.Longitud);
                __builder2.CloseElement();
#nullable restore
#line 97 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                             if (roleloged == "Administrator" || roleloged == "Master")
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-floating mb-3");
                __builder2.AddMarkupContent(99, "<label>Estatus</label>\r\n                                    ");
                __Blazor.CRUDProject5.Pages.EditarEliminar.TypeInference.CreateInputSelect_2(__builder2, 100, 101, 
#nullable restore
#line 101 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                               ObRep.IdStatus

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ObRep.IdStatus = __value, ObRep.IdStatus)), 103, () => ObRep.IdStatus, 104, (__builder3) => {
                    __builder3.AddMarkupContent(105, "<option value=\"1\">Recibido</option>\r\n                                        ");
                    __builder3.AddMarkupContent(106, "<option value=\"2\">En atencion</option>\r\n                                        ");
                    __builder3.AddMarkupContent(107, "<option value=\"3\">Finalizado</option>");
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 108 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"

                            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "d-grid text-center");
                __builder2.OpenElement(110, "button");
                __builder2.AddAttribute(111, "type", "submit");
                __builder2.AddAttribute(112, "class", "btn btn-info btn-lg ");
                __builder2.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                             Actualizar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(114, "Actualizar reporte");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                                ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "class", "btn btn-warning btn-lg ");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(119, "Eliminar reporte");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                            ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "d-grid text-center");
                __builder2.OpenElement(123, "button");
                __builder2.AddAttribute(124, "class", "btn btn-primary btn-lg ");
                __builder2.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
                                                                                                              Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(126, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n");
            __builder.AddMarkupContent(128, @"<footer class=""bg-dark py-4 mt-auto""><div class=""container px-5""><div class=""row align-items-center justify-content-between flex-column flex-sm-row""><div class=""col-auto""><div class=""small m-0 text-white"">Copyright &copy; Universidad Tecnol??gica Metropolitana 2022</div></div>
            <div class=""col-auto""><a class=""link-light small"" href=""#!"">Privacy</a>
                <span class=""text-white mx-1"">&middot;</span>
                <a class=""link-light small"" href=""#!"">Terms</a>
                <span class=""text-white mx-1"">&middot;</span>
                <a class=""link-light small"" href=""#!"">Contact</a></div></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\jimmy\source\repos\CRUDProject5\CRUDProject5\Pages\EditarEliminar.razor"
       

    public string userloged { get; set; }
    public string roleloged { get; set; }
    public string nameloged { get; set; }

    [Parameter]
    public int Id { get; set; }

    Report ObRep = new Report();
    Respuesta<object> oRes = new Respuesta<object>();
    Respuesta<Report> oResReport = new Respuesta<Report>();
    public string Url = "api/report";

    private void HandleValidSubmit()
    {
        Logger.LogInformation("HandleValidSubmit called");

        // Process the valid form
    }

    private async Task Actualizar()


    {
        ObRep.ImageUbicaton = null;
        var response = await Http.PutAsJsonAsync<Report>(Url, ObRep);
        oRes = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        Navegacion.NavigateTo("/reportes");
    }

    private async Task Eliminar()


    {
        var response = await Http.DeleteAsync(Url + "/" + Id);
        oRes = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        Navegacion.NavigateTo("/reportes");
    }

    private void Cancelar() => Navegacion.NavigateTo("/reportes");

    protected override async Task OnInitializedAsync()
    {


        var format = "image/png";
        oResReport = await Http.GetFromJsonAsync<Respuesta<Report>>(Url + "/" + Id);
        ObRep = oResReport.Data;
        var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(ObRep.Foto)}";
        ObRep.ImageUbicaton = imageDataUrl;

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {


        if (firstRender)
        {
            userloged = await localStorage.GetItemAsync<string>("IdUserLoged");
            roleloged = await localStorage.GetItemAsync<string>("Rol");
            nameloged = await localStorage.GetItemAsync<string>("nombre");
            StateHasChanged();

            await _jsRun.InvokeVoidAsync("getMapById", ObRep);

        }
        else
        {
            await _jsRun.InvokeVoidAsync("getMapById", ObRep);
        }
    }

    private IList<string> imageDateUrls = new List<string>();

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {


        var maxAllowedFiles = 1;
        var format = "image/png";
        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedFile = await imageFile.RequestImageFileAsync(format, 500, 500);
            var buffer = new byte[resizedFile.Size];

            ObRep.Foto = buffer;

            await resizedFile.OpenReadStream().ReadAsync(buffer);

            var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

            imageDateUrls.Add(imageDataUrl);
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<EditarEliminar> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRun { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navegacion { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.CRUDProject5.Pages.EditarEliminar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
