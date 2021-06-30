Ext.define("ClientApp.model.Reservation", {
  extend: "ClientApp.model.Base",

  fields: [
    "code",
    "checkInDate",
    "checkOutDate",
    "createdAt",
    "price",
    "currency",
    "commissionFee",
    "source",
  ],
});
