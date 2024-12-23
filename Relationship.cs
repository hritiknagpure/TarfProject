protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Configure the one-to-one relationship
    modelBuilder.Entity<Product>()
        .HasOne(p => p.ProductDetail) // A Product has one ProductDetail
        .WithOne(pd => pd.Product) // A ProductDetail has one Product
        .HasForeignKey<ProductDetail>(pd => pd.ProductId); // Foreign key in ProductDetail
}



protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Configure the one-to-many relationship
    modelBuilder.Entity<Product>()
        .HasMany(p => p.ProductDetails) // A Product has many ProductDetails
        .WithOne(pd => pd.Product)     // Each ProductDetail belongs to one Product
        .HasForeignKey(pd => pd.ProductId); // Foreign key in ProductDetail
}
