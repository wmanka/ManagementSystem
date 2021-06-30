/**
 * This view is an example list of people.
 */
Ext.define("ClientApp.view.main.List", {
  extend: "Ext.grid.Grid",
  xtype: "mainlist",

  requires: ["ClientApp.store.Reservation"],

  title: "Reservation",

  store: {
    type: "reservation",
  },

  columns: [
    {
      text: "Code",
      dataIndex: "code",
      width: 100,
      cell: {
        userCls: "bold",
      },
    },
    {
      text: "CreatedAt",
      dataIndex: "createdAt",
      width: 230,
    },
    {
      text: "CheckInDate",
      dataIndex: "checkInDate",
      width: 150,
    },
    {
      text: "CheckOutDate",
      dataIndex: "checkOutDate",
      width: 150,
    },
    {
      text: "Price",
      dataIndex: "price",
      width: 150,
    },
    {
      text: "Currency",
      dataIndex: "currency",
      width: 150,
    },
    {
      text: "CommissionFee",
      dataIndex: "commissionFee",
      width: 150,
    },
    {
      text: "Source",
      dataIndex: "source",
      width: 150,
    },
  ],

  listeners: {
    select: "onItemSelected",
  },
});
