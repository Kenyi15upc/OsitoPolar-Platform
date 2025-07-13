﻿namespace OsitoPolarPlatform.API.SubscriptionsAndPayments.Interfaces.REST.Resources;

public record SubscriptionResource(int Id, string PlanName, decimal Price, string BillingCycle, int? MaxEquipment, int? MaxClients, List<string> Features);