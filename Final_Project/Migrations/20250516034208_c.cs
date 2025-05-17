using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 3,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 4,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 5,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 17, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 18, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 3,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 19, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 4,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 20, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 5,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 21, 6, 42, 6, 355, DateTimeKind.Local).AddTicks(5700));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "OrderTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5,
                column: "PaymentTime",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 1,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 2,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 3,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 4,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 5,
                column: "RegisteredDate",
                value: new DateTime(2025, 5, 16, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 17, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 18, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 3,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 19, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 4,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 20, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 5,
                column: "ReservationTime",
                value: new DateTime(2025, 5, 21, 6, 37, 58, 340, DateTimeKind.Local).AddTicks(1970));
        }
    }
}
