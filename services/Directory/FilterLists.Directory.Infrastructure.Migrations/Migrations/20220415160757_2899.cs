﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    public partial class _2899 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2579L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2580L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google.");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2581L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google.");

            migrationBuilder.InsertData(
                table: "filter_lists",
                columns: new[] { "id", "chat_url", "description", "donate_url", "email_address", "forum_url", "home_url", "is_approved", "issues_url", "license_id", "name", "onion_url", "policy_url", "submission_url" },
                values: new object[] { 2582L, null, "Whitelist for Ad Blockers, helps to unblock false positives.", null, null, null, "https://github.com/DevShubam/Whitelist", true, "https://github.com/DevShubam/Whitelist/issues", 2L, "Shub's Whitelist", null, null, null });

            migrationBuilder.InsertData(
                table: "maintainers",
                columns: new[] { "id", "email_address", "is_approved", "name", "twitter_handle", "url" },
                values: new object[] { 175L, null, true, "DevShubam", null, "https://github.com/DevShubam" });

            migrationBuilder.InsertData(
                table: "filter_list_maintainers",
                columns: new[] { "filter_list_id", "maintainer_id" },
                values: new object[] { 2582L, 175L });

            migrationBuilder.InsertData(
                table: "filter_list_syntaxes",
                columns: new[] { "filter_list_id", "syntax_id" },
                values: new object[] { 2582L, 9L });

            migrationBuilder.InsertData(
                table: "filter_list_tags",
                columns: new[] { "filter_list_id", "tag_id" },
                values: new object[] { 2582L, 10L });

            migrationBuilder.InsertData(
                table: "filter_list_view_urls",
                columns: new[] { "filter_list_id", "id", "primariness", "url" },
                values: new object[] { 2582L, 2847L, (short)1, "https://raw.githubusercontent.com/DevShubam/Whitelist/master/whitelist.txt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "filter_list_maintainers",
                keyColumns: new[] { "filter_list_id", "maintainer_id" },
                keyValues: new object[] { 2582L, 175L });

            migrationBuilder.DeleteData(
                table: "filter_list_syntaxes",
                keyColumns: new[] { "filter_list_id", "syntax_id" },
                keyValues: new object[] { 2582L, 9L });

            migrationBuilder.DeleteData(
                table: "filter_list_tags",
                keyColumns: new[] { "filter_list_id", "tag_id" },
                keyValues: new object[] { 2582L, 10L });

            migrationBuilder.DeleteData(
                table: "filter_list_view_urls",
                keyColumns: new[] { "filter_list_id", "id" },
                keyValues: new object[] { 2582L, 2847L });

            migrationBuilder.DeleteData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2582L);

            migrationBuilder.DeleteData(
                table: "maintainers",
                keyColumn: "id",
                keyValue: 175L);

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2579L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google. ");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2580L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google. ");

            migrationBuilder.UpdateData(
                table: "filter_lists",
                keyColumn: "id",
                keyValue: 2581L,
                column: "description",
                value: "Malicious URL blocklists for DNSBL applications like pfBlockerNG or Pi-hole, automatically updated every 24 hours. These blocklists are automatically generated by scanning various public URL sources using the Safe Browsing API from Google. ");
        }
    }
}