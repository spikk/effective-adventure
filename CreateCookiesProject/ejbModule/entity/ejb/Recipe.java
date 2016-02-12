package entity.ejb;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.JoinColumns;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Recipe")
public class Recipe {

	private RecipeId iNumberPNumber;
	private double quantity;
	private Ingredient ingredient;
	private Product product;

	@EmbeddedId
	public RecipeId getiNumberPNumber() {
		return iNumberPNumber;
	}

	public void setiNumberPNumber(RecipeId iNumberPNumber) {
		this.iNumberPNumber = iNumberPNumber;
	}

	@Column(name = "quantity")
	public double getQuantity() {
		return quantity;
	}

	public void setQuantity(double quantity) {
		this.quantity = quantity;
	}

	@ManyToOne
	@JoinColumn(name = "iNumber_FK", referencedColumnName = "iNumber")
//	@JoinColumns({ @JoinColumn(name = "iNumber_FK", referencedColumnName = "iNumber"),
//			@JoinColumn(name = "pNumber_FK", referencedColumnName = "iNumber") })
	public Ingredient getIngredient() {
		return ingredient;
	}

	public void setIngredient(Ingredient ingredient) {
		this.ingredient = ingredient;
	}

	@ManyToOne
	@JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber")
//	@JoinColumns({ @JoinColumn(name = "iNumber_FK", referencedColumnName = "pNumber"),
//			@JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber") })
	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

}
