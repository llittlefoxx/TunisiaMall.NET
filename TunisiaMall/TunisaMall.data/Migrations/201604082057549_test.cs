namespace TunisaMall.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "anonimousrating",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    date = c.DateTime(precision: 0),
                    idProd = c.Int(nullable: false),
                    rate = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "category",
                c => new
                {
                    idCategory = c.Int(nullable: false, identity: true),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    libelle = c.String(maxLength: 255, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.idCategory);

            CreateTable(
                "shoprequest",
                c => new
                {
                    idRequest = c.Int(nullable: false, identity: true),
                    address = c.String(maxLength: 255, storeType: "nvarchar"),
                    birthdate = c.DateTime(precision: 0),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    email = c.String(maxLength: 255, storeType: "nvarchar"),
                    firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                    job = c.String(maxLength: 255, storeType: "nvarchar"),
                    lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                    phone = c.String(maxLength: 255, storeType: "nvarchar"),
                    plannedOpeningDate = c.DateTime(precision: 0),
                    rcptDate = c.DateTime(precision: 0),
                    rentPeriod = c.Int(),
                    status = c.Boolean(nullable: false),
                    storeInMall = c.Boolean(nullable: false),
                    category_fk = c.Int(),
                })
                .PrimaryKey(t => t.idRequest)
                .ForeignKey("category", t => t.category_fk)
                .Index(t => t.category_fk);

            CreateTable(
                "store",
                c => new
                {
                    idStroe = c.Int(nullable: false, identity: true),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    name = c.String(maxLength: 255, storeType: "nvarchar"),
                    openingDay = c.DateTime(precision: 0),
                    status = c.String(maxLength: 255, storeType: "nvarchar"),
                    tel = c.String(maxLength: 255, storeType: "nvarchar"),
                    category_fk = c.Int(),
                    idUser = c.Int(),
                })
                .PrimaryKey(t => t.idStroe)
                .ForeignKey("category", t => t.category_fk)
                .ForeignKey("user", t => t.idUser)
                .Index(t => t.category_fk)
                .Index(t => t.idUser);

            CreateTable(
                "event",
                c => new
                {
                    idEvent = c.Int(nullable: false, identity: true),
                    dateEvent = c.DateTime(precision: 0),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    periodEvent = c.Int(nullable: false),
                    titleEvent = c.String(maxLength: 255, storeType: "nvarchar"),
                    typeEvent = c.String(maxLength: 255, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.idEvent);

            CreateTable(
                "subscriptions",
                c => new
                {
                    idEvent = c.Int(nullable: false),
                    idSubscription = c.Int(nullable: false),
                    idUser = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.idEvent, t.idSubscription, t.idUser })
                .ForeignKey("event", t => t.idEvent, cascadeDelete: true)
                .ForeignKey("user", t => t.idUser, cascadeDelete: true)
                .Index(t => t.idEvent)
                .Index(t => t.idUser);

            CreateTable(
                "user",
                c => new
                {
                    idUser = c.Int(nullable: false, identity: true),
                    USER_TYPE = c.String(maxLength: 31, storeType: "nvarchar"),
                    address = c.String(maxLength: 255, storeType: "nvarchar"),
                    baned = c.Boolean(),
                    birthdate = c.DateTime(precision: 0),
                    firstName = c.String(maxLength: 255, storeType: "nvarchar"),
                    gender = c.String(maxLength: 255, storeType: "nvarchar"),
                    job = c.String(maxLength: 255, storeType: "nvarchar"),
                    lastName = c.String(maxLength: 255, storeType: "nvarchar"),
                    login = c.String(maxLength: 255, storeType: "nvarchar"),
                    mail = c.String(maxLength: 255, storeType: "nvarchar"),
                    password = c.String(maxLength: 255, storeType: "nvarchar"),
                    phone = c.String(maxLength: 255, storeType: "nvarchar"),
                    pictureUrl = c.String(maxLength: 255, storeType: "nvarchar"),
                    facturationAddr = c.String(unicode: false),
                    shipementAddr = c.String(unicode: false),
                    dateActivation = c.DateTime(precision: 0),
                })
                .PrimaryKey(t => t.idUser);

            CreateTable(
                "comment",
                c => new
                {
                    idComment = c.Int(nullable: false, identity: true),
                    commentDate = c.DateTime(precision: 0),
                    rating = c.Int(nullable: false),
                    text = c.String(maxLength: 255, storeType: "nvarchar"),
                    idPost = c.Int(),
                    idUser = c.Int(),
                })
                .PrimaryKey(t => t.idComment)
                .ForeignKey("post", t => t.idPost)
                .ForeignKey("user", t => t.idUser)
                .Index(t => t.idPost)
                .Index(t => t.idUser);

            CreateTable(
                "post",
                c => new
                {
                    idPost = c.Int(nullable: false, identity: true),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    rating = c.Int(nullable: false),
                    idUser = c.Int(),
                })
                .PrimaryKey(t => t.idPost)
                .ForeignKey("user", t => t.idUser)
                .Index(t => t.idUser);

            CreateTable(
                "complaint",
                c => new
                {
                    idComplaint = c.Int(nullable: false, identity: true),
                    complaintDate = c.DateTime(precision: 0),
                    nature = c.String(maxLength: 255, storeType: "nvarchar"),
                    text = c.String(maxLength: 255, storeType: "nvarchar"),
                    idUser = c.Int(),
                })
                .PrimaryKey(t => t.idComplaint)
                .ForeignKey("user", t => t.idUser)
                .Index(t => t.idUser);

            CreateTable(
                "friendship",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    accepted = c.Boolean(nullable: false),
                    idUser1 = c.Int(),
                    idUser2 = c.Int(),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("user", t => t.idUser1)
                .ForeignKey("user", t => t.idUser2)
                .Index(t => t.idUser1)
                .Index(t => t.idUser2);

            CreateTable(
                "gestbookentry",
                c => new
                {
                    idEntries = c.Int(nullable: false, identity: true),
                    dateEntrie = c.DateTime(precision: 0),
                    rating = c.Int(nullable: false),
                    text = c.String(maxLength: 255, storeType: "nvarchar"),
                    user_idUser = c.Int(),
                })
                .PrimaryKey(t => t.idEntries)
                .ForeignKey("user", t => t.user_idUser)
                .Index(t => t.user_idUser);

            CreateTable(
                "message",
                c => new
                {
                    idMessage = c.Int(nullable: false, identity: true),
                    date = c.DateTime(precision: 0),
                    text = c.String(maxLength: 255, storeType: "nvarchar"),
                    idUserReciver_fk = c.Int(),
                    idUserSender_FK = c.Int(),
                })
                .PrimaryKey(t => t.idMessage)
                .ForeignKey("user", t => t.idUserReciver_fk)
                .ForeignKey("user", t => t.idUserSender_FK)
                .Index(t => t.idUserReciver_fk)
                .Index(t => t.idUserSender_FK);

            CreateTable(
                "orders",
                c => new
                {
                    idOrder = c.Int(nullable: false, identity: true),
                    amountPayed = c.Decimal(precision: 18, scale: 2),
                    cardHolder = c.String(maxLength: 255, storeType: "nvarchar"),
                    date = c.DateTime(precision: 0),
                    datePay = c.DateTime(precision: 0),
                    orderStatus = c.String(maxLength: 255, storeType: "nvarchar"),
                    statusPayment = c.String(maxLength: 255, storeType: "nvarchar"),
                    idUser = c.Int(),
                })
                .PrimaryKey(t => t.idOrder)
                .ForeignKey("user", t => t.idUser)
                .Index(t => t.idUser);

            CreateTable(
                "orderline",
                c => new
                {
                    idOrderLine = c.Int(nullable: false),
                    qte = c.Int(nullable: false),
                    idOrder_fk = c.Int(),
                    idProduct_fk = c.Int(),
                })
                .PrimaryKey(t => t.idOrderLine)
                .ForeignKey("orders", t => t.idOrder_fk)
                .ForeignKey("product", t => t.idProduct_fk)
                .Index(t => t.idOrder_fk)
                .Index(t => t.idProduct_fk);

            CreateTable(
                "product",
                c => new
                {
                    idProduct = c.Int(nullable: false, identity: true),
                    buyPrice = c.Double(nullable: false),
                    criticalZone = c.Int(nullable: false),
                    expDate = c.DateTime(precision: 0),
                    libelle = c.String(maxLength: 255, storeType: "nvarchar"),
                    qte = c.Int(nullable: false),
                    sellPrice = c.Double(nullable: false),
                    state = c.String(maxLength: 255, storeType: "nvarchar"),
                    tag = c.String(maxLength: 255, storeType: "nvarchar"),
                    tax = c.Double(nullable: false),
                    Promotion_idPromotion = c.Long(),
                    IdPromotionSuggest_fk = c.Int(),
                    IdStore = c.Int(),
                    IdSubCategory = c.Int(),
                })
                .PrimaryKey(t => t.idProduct)
                .ForeignKey("promotion", t => t.Promotion_idPromotion)
                .ForeignKey("promotionsuggest", t => t.IdPromotionSuggest_fk)
                .ForeignKey("store", t => t.IdStore)
                .ForeignKey("subcategory", t => t.IdSubCategory)
                .Index(t => t.Promotion_idPromotion)
                .Index(t => t.IdPromotionSuggest_fk)
                .Index(t => t.IdStore)
                .Index(t => t.IdSubCategory);

            CreateTable(
                "images",
                c => new
                {
                    idImage = c.Int(nullable: false, identity: true),
                    imagePath = c.String(maxLength: 255, storeType: "nvarchar"),
                    idProduct = c.Int(),
                })
                .PrimaryKey(t => t.idImage)
                .ForeignKey("product", t => t.idProduct)
                .Index(t => t.idProduct);

            CreateTable(
                "mvtstock",
                c => new
                {
                    idMvt = c.Int(nullable: false, identity: true),
                    date = c.DateTime(precision: 0),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    nature = c.String(maxLength: 255, storeType: "nvarchar"),
                    qte = c.Int(nullable: false),
                    supplier = c.Int(nullable: false),
                    idProduct = c.Int(),
                })
                .PrimaryKey(t => t.idMvt)
                .ForeignKey("product", t => t.idProduct)
                .Index(t => t.idProduct);

            CreateTable(
                "promotion",
                c => new
                {
                    idPromotion = c.Long(nullable: false),
                    endDate = c.DateTime(precision: 0),
                    name = c.String(maxLength: 255, storeType: "nvarchar"),
                    startDate = c.DateTime(precision: 0),
                    state = c.Boolean(nullable: false),
                    value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.idPromotion);

            CreateTable(
                "promotionsuggest",
                c => new
                {
                    idPromotionSuggest = c.Int(nullable: false, identity: true),
                    desccription = c.String(maxLength: 255, storeType: "nvarchar"),
                    endDate = c.DateTime(precision: 0),
                    name = c.String(maxLength: 255, storeType: "nvarchar"),
                    startDate = c.DateTime(precision: 0),
                    suggestionDate = c.DateTime(precision: 0),
                    value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.idPromotionSuggest);

            CreateTable(
                "subcategory",
                c => new
                {
                    idSubCategory = c.Int(nullable: false, identity: true),
                    description = c.String(maxLength: 255, storeType: "nvarchar"),
                    libelle = c.String(maxLength: 255, storeType: "nvarchar"),
                    idCategory = c.Int(),
                })
                .PrimaryKey(t => t.idSubCategory)
                .ForeignKey("category", t => t.idCategory)
                .Index(t => t.idCategory);

            CreateTable(
                "storeevent",
                c => new
                {
                    idStore = c.Int(nullable: false),
                    idEvent = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.idStore, t.idEvent })
                .ForeignKey("store", t => t.idStore, cascadeDelete: true)
                .ForeignKey("event", t => t.idEvent, cascadeDelete: true)
                .Index(t => t.idStore)
                .Index(t => t.idEvent);

        }

        public override void Down()
        {
            DropForeignKey("store", "idUser", "user");
            DropForeignKey("storeevent", "idEvent", "event");
            DropForeignKey("storeevent", "idStore", "store");
            DropForeignKey("subscriptions", "idUser", "user");
            DropForeignKey("orders", "idUser", "user");
            DropForeignKey("orderline", "idProduct_fk", "product");
            DropForeignKey("product", "IdSubCategory", "subcategory");
            DropForeignKey("subcategory", "idCategory", "category");
            DropForeignKey("product", "IdStore", "store");
            DropForeignKey("product", "IdPromotionSuggest_fk", "promotionsuggest");
            DropForeignKey("product", "Promotion_idPromotion", "promotion");
            DropForeignKey("mvtstock", "idProduct", "product");
            DropForeignKey("images", "idProduct", "product");
            DropForeignKey("orderline", "idOrder_fk", "orders");
            DropForeignKey("message", "idUserSender_FK", "user");
            DropForeignKey("message", "idUserReciver_fk", "user");
            DropForeignKey("gestbookentry", "user_idUser", "user");
            DropForeignKey("friendship", "idUser2", "user");
            DropForeignKey("friendship", "idUser1", "user");
            DropForeignKey("complaint", "idUser", "user");
            DropForeignKey("comment", "idUser", "user");
            DropForeignKey("comment", "idPost", "post");
            DropForeignKey("post", "idUser", "user");
            DropForeignKey("subscriptions", "idEvent", "event");
            DropForeignKey("store", "category_fk", "category");
            DropForeignKey("shoprequest", "category_fk", "category");
            DropIndex("storeevent", new[] { "idEvent" });
            DropIndex("storeevent", new[] { "idStore" });
            DropIndex("subcategory", new[] { "idCategory" });
            DropIndex("mvtstock", new[] { "idProduct" });
            DropIndex("images", new[] { "idProduct" });
            DropIndex("product", new[] { "IdSubCategory" });
            DropIndex("product", new[] { "IdStore" });
            DropIndex("product", new[] { "IdPromotionSuggest_fk" });
            DropIndex("product", new[] { "Promotion_idPromotion" });
            DropIndex("orderline", new[] { "idProduct_fk" });
            DropIndex("orderline", new[] { "idOrder_fk" });
            DropIndex("orders", new[] { "idUser" });
            DropIndex("message", new[] { "idUserSender_FK" });
            DropIndex("message", new[] { "idUserReciver_fk" });
            DropIndex("gestbookentry", new[] { "user_idUser" });
            DropIndex("friendship", new[] { "idUser2" });
            DropIndex("friendship", new[] { "idUser1" });
            DropIndex("complaint", new[] { "idUser" });
            DropIndex("post", new[] { "idUser" });
            DropIndex("comment", new[] { "idUser" });
            DropIndex("comment", new[] { "idPost" });
            DropIndex("subscriptions", new[] { "idUser" });
            DropIndex("subscriptions", new[] { "idEvent" });
            DropIndex("store", new[] { "idUser" });
            DropIndex("store", new[] { "category_fk" });
            DropIndex("shoprequest", new[] { "category_fk" });
            DropTable("storeevent");
            DropTable("subcategory");
            DropTable("promotionsuggest");
            DropTable("promotion");
            DropTable("mvtstock");
            DropTable("images");
            DropTable("product");
            DropTable("orderline");
            DropTable("orders");
            DropTable("message");
            DropTable("gestbookentry");
            DropTable("friendship");
            DropTable("complaint");
            DropTable("post");
            DropTable("comment");
            DropTable("user");
            DropTable("subscriptions");
            DropTable("event");
            DropTable("store");
            DropTable("shoprequest");
            DropTable("category");
            DropTable("anonimousrating");
        }
    }
}
