/**
 * This view is an example list of people.
 */
Ext.define("ClientApp.view.main.List", {
  extend: "Ext.grid.Panel",
  xtype: "mainlist",

  requires: ["ClientApp.store.Reservation"],

  title: "Reservations",

  store: {
    type: "reservation",
  },

  columns: [
    { text: "Code", dataIndex: "code" },
    { text: "CreatedAt", dataIndex: "createdAt", flex: 1 },
    { text: "CheckInDate", dataIndex: "checkInDate", flex: 1 },
    { text: "CheckOutDate", dataIndex: "checkOutDate", flex: 1 },
    { text: "Price", dataIndex: "price", flex: 1 },
    { text: "Currency", dataIndex: "currency", flex: 1 },
    { text: "CommisionFee", dataIndex: "commissionFee", flex: 1 },
    { text: "Source", dataIndex: "source", flex: 1 },
  ],

  listeners: {
    select: "onItemSelected",
  },
});
