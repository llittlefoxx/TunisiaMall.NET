namespace TunisaMall.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class heritage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "pidevtunisiamall.anonimousrating",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        idProd = c.Int(nullable: false),
                        rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "pidevtunisiamall.category",
                c => new
                    {
                        idCategory = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        libelle = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idCategory);
            
            CreateTable(
                "pidevtunisiamall.shoprequest",
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
                .ForeignKey("pidevtunisiamall.category", t => t.category_fk)
                .Index(t => t.category_fk);
            
            CreateTable(
                "pidevtunisiamall.store",
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
                .ForeignKey("pidevtunisiamall.category", t => t.category_fk)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser)
                .Index(t => t.category_fk)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.event",
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
                "pidevtunisiamall.subscriptions",
                c => new
                    {
                        idEvent = c.Int(nullable: false),
                        idSubscription = c.Int(nullable: false),
                        idUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idEvent, t.idSubscription, t.idUser })
                .ForeignKey("pidevtunisiamall.event", t => t.idEvent, cascadeDelete: true)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser, cascadeDelete: true)
                .Index(t => t.idEvent)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.user",
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
                "pidevtunisiamall.comment",
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
                .ForeignKey("pidevtunisiamall.post", t => t.idPost)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser)
                .Index(t => t.idPost)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.post",
                c => new
                    {
                        idPost = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        rating = c.Int(nullable: false),
                        idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idPost)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.complaint",
                c => new
                    {
                        idComplaint = c.Int(nullable: false, identity: true),
                        complaintDate = c.DateTime(precision: 0),
                        nature = c.String(maxLength: 255, storeType: "nvarchar"),
                        text = c.String(maxLength: 255, storeType: "nvarchar"),
                        idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idComplaint)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.friendship",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        accepted = c.Boolean(nullable: false),
                        idUser1 = c.Int(),
                        idUser2 = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser1)
                .ForeignKey("pidevtunisiamall.user", t => t.idUser2)
                .Index(t => t.idUser1)
                .Index(t => t.idUser2);
            
            CreateTable(
                "pidevtunisiamall.gestbookentry",
                c => new
                    {
                        idEntries = c.Int(nullable: false, identity: true),
                        dateEntrie = c.DateTime(precision: 0),
                        rating = c.Int(nullable: false),
                        text = c.String(maxLength: 255, storeType: "nvarchar"),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idEntries)
                .ForeignKey("pidevtunisiamall.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "pidevtunisiamall.message",
                c => new
                    {
                        idMessage = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        text = c.String(maxLength: 255, storeType: "nvarchar"),
                        idUserReciver_fk = c.Int(),
                        idUserSender_FK = c.Int(),
                    })
                .PrimaryKey(t => t.idMessage)
                .ForeignKey("pidevtunisiamall.user", t => t.idUserReciver_fk)
                .ForeignKey("pidevtunisiamall.user", t => t.idUserSender_FK)
                .Index(t => t.idUserReciver_fk)
                .Index(t => t.idUserSender_FK);
            
            CreateTable(
                "pidevtunisiamall.orders",
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
                .ForeignKey("pidevtunisiamall.user", t => t.idUser)
                .Index(t => t.idUser);
            
            CreateTable(
                "pidevtunisiamall.orderline",
                c => new
                    {
                        idOrderLine = c.Int(nullable: false),
                        qte = c.Int(nullable: false),
                        idOrder_fk = c.Int(),
                        idProduct_fk = c.Int(),
                    })
                .PrimaryKey(t => t.idOrderLine)
                .ForeignKey("pidevtunisiamall.orders", t => t.idOrder_fk)
                .ForeignKey("pidevtunisiamall.product", t => t.idProduct_fk)
                .Index(t => t.idOrder_fk)
                .Index(t => t.idProduct_fk);
            
            CreateTable(
                "pidevtunisiamall.product",
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
                .ForeignKey("pidevtunisiamall.promotion", t => t.Promotion_idPromotion)
                .ForeignKey("pidevtunisiamall.promotionsuggest", t => t.IdPromotionSuggest_fk)
                .ForeignKey("pidevtunisiamall.store", t => t.IdStore)
                .ForeignKey("pidevtunisiamall.subcategory", t => t.IdSubCategory)
                .Index(t => t.Promotion_idPromotion)
                .Index(t => t.IdPromotionSuggest_fk)
                .Index(t => t.IdStore)
                .Index(t => t.IdSubCategory);
            
            CreateTable(
                "pidevtunisiamall.images",
                c => new
                    {
                        idImage = c.Int(nullable: false, identity: true),
                        imagePath = c.String(maxLength: 255, storeType: "nvarchar"),
                        idProduct = c.Int(),
                    })
                .PrimaryKey(t => t.idImage)
                .ForeignKey("pidevtunisiamall.product", t => t.idProduct)
                .Index(t => t.idProduct);
            
            CreateTable(
                "pidevtunisiamall.mvtstock",
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
                .ForeignKey("pidevtunisiamall.product", t => t.idProduct)
                .Index(t => t.idProduct);
            
            CreateTable(
                "pidevtunisiamall.promotion",
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
                "pidevtunisiamall.promotionsuggest",
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
                "pidevtunisiamall.subcategory",
                c => new
                    {
                        idSubCategory = c.Int(nullable: false, identity: true),
                        description = c.String(maxLength: 255, storeType: "nvarchar"),
                        libelle = c.String(maxLength: 255, storeType: "nvarchar"),
                        idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idSubCategory)
                .ForeignKey("pidevtunisiamall.category", t => t.idCategory)
                .Index(t => t.idCategory);
            
            CreateTable(
                "pidevtunisiamall.storeevent",
                c => new
                    {
                        idStore = c.Int(nullable: false),
                        idEvent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.idStore, t.idEvent })
                .ForeignKey("pidevtunisiamall.store", t => t.idStore, cascadeDelete: true)
                .ForeignKey("pidevtunisiamall.event", t => t.idEvent, cascadeDelete: true)
                .Index(t => t.idStore)
                .Index(t => t.idEvent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("pidevtunisiamall.store", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.storeevent", "idEvent", "pidevtunisiamall.event");
            DropForeignKey("pidevtunisiamall.storeevent", "idStore", "pidevtunisiamall.store");
            DropForeignKey("pidevtunisiamall.subscriptions", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.orders", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.orderline", "idProduct_fk", "pidevtunisiamall.product");
            DropForeignKey("pidevtunisiamall.product", "IdSubCategory", "pidevtunisiamall.subcategory");
            DropForeignKey("pidevtunisiamall.subcategory", "idCategory", "pidevtunisiamall.category");
            DropForeignKey("pidevtunisiamall.product", "IdStore", "pidevtunisiamall.store");
            DropForeignKey("pidevtunisiamall.product", "IdPromotionSuggest_fk", "pidevtunisiamall.promotionsuggest");
            DropForeignKey("pidevtunisiamall.product", "Promotion_idPromotion", "pidevtunisiamall.promotion");
            DropForeignKey("pidevtunisiamall.mvtstock", "idProduct", "pidevtunisiamall.product");
            DropForeignKey("pidevtunisiamall.images", "idProduct", "pidevtunisiamall.product");
            DropForeignKey("pidevtunisiamall.orderline", "idOrder_fk", "pidevtunisiamall.orders");
            DropForeignKey("pidevtunisiamall.message", "idUserSender_FK", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.message", "idUserReciver_fk", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.gestbookentry", "user_idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.friendship", "idUser2", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.friendship", "idUser1", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.complaint", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.comment", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.comment", "idPost", "pidevtunisiamall.post");
            DropForeignKey("pidevtunisiamall.post", "idUser", "pidevtunisiamall.user");
            DropForeignKey("pidevtunisiamall.subscriptions", "idEvent", "pidevtunisiamall.event");
            DropForeignKey("pidevtunisiamall.store", "category_fk", "pidevtunisiamall.category");
            DropForeignKey("pidevtunisiamall.shoprequest", "category_fk", "pidevtunisiamall.category");
            DropIndex("pidevtunisiamall.storeevent", new[] { "idEvent" });
            DropIndex("pidevtunisiamall.storeevent", new[] { "idStore" });
            DropIndex("pidevtunisiamall.subcategory", new[] { "idCategory" });
            DropIndex("pidevtunisiamall.mvtstock", new[] { "idProduct" });
            DropIndex("pidevtunisiamall.images", new[] { "idProduct" });
            DropIndex("pidevtunisiamall.product", new[] { "IdSubCategory" });
            DropIndex("pidevtunisiamall.product", new[] { "IdStore" });
            DropIndex("pidevtunisiamall.product", new[] { "IdPromotionSuggest_fk" });
            DropIndex("pidevtunisiamall.product", new[] { "Promotion_idPromotion" });
            DropIndex("pidevtunisiamall.orderline", new[] { "idProduct_fk" });
            DropIndex("pidevtunisiamall.orderline", new[] { "idOrder_fk" });
            DropIndex("pidevtunisiamall.orders", new[] { "idUser" });
            DropIndex("pidevtunisiamall.message", new[] { "idUserSender_FK" });
            DropIndex("pidevtunisiamall.message", new[] { "idUserReciver_fk" });
            DropIndex("pidevtunisiamall.gestbookentry", new[] { "user_idUser" });
            DropIndex("pidevtunisiamall.friendship", new[] { "idUser2" });
            DropIndex("pidevtunisiamall.friendship", new[] { "idUser1" });
            DropIndex("pidevtunisiamall.complaint", new[] { "idUser" });
            DropIndex("pidevtunisiamall.post", new[] { "idUser" });
            DropIndex("pidevtunisiamall.comment", new[] { "idUser" });
            DropIndex("pidevtunisiamall.comment", new[] { "idPost" });
            DropIndex("pidevtunisiamall.subscriptions", new[] { "idUser" });
            DropIndex("pidevtunisiamall.subscriptions", new[] { "idEvent" });
            DropIndex("pidevtunisiamall.store", new[] { "idUser" });
            DropIndex("pidevtunisiamall.store", new[] { "category_fk" });
            DropIndex("pidevtunisiamall.shoprequest", new[] { "category_fk" });
            DropTable("pidevtunisiamall.storeevent");
            DropTable("pidevtunisiamall.subcategory");
            DropTable("pidevtunisiamall.promotionsuggest");
            DropTable("pidevtunisiamall.promotion");
            DropTable("pidevtunisiamall.mvtstock");
            DropTable("pidevtunisiamall.images");
            DropTable("pidevtunisiamall.product");
            DropTable("pidevtunisiamall.orderline");
            DropTable("pidevtunisiamall.orders");
            DropTable("pidevtunisiamall.message");
            DropTable("pidevtunisiamall.gestbookentry");
            DropTable("pidevtunisiamall.friendship");
            DropTable("pidevtunisiamall.complaint");
            DropTable("pidevtunisiamall.post");
            DropTable("pidevtunisiamall.comment");
            DropTable("pidevtunisiamall.user");
            DropTable("pidevtunisiamall.subscriptions");
            DropTable("pidevtunisiamall.event");
            DropTable("pidevtunisiamall.store");
            DropTable("pidevtunisiamall.shoprequest");
            DropTable("pidevtunisiamall.category");
            DropTable("pidevtunisiamall.anonimousrating");
        }
    }
}
