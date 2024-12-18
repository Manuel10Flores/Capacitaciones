﻿using Carter;
using Capacitaciones.Api.Capacitacion.CrearCapacitacion;
using Capacitaciones.Api.Capacitacion.LeerCapacitacion;
using Capacitaciones.Api.Capacitacion.EliminarCapacitacion;


namespace Capacitaciones.Api.Capacitacion;

public class Endpoints:CarterModule
{
    public Endpoints():base("/api/v1/capacitacion")
    {
        this.WithTags("Capacitacion");

    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
          app.CrearCapacitacion();
          app.LeerCapacitacion();
          app.EliminarCapacitacion();

    }
}
