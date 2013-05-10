class News < ActiveRecord::Base
  attr_accessible :author, :content, :title
  has_many :comments

  validates :author, :content, :title, :presence =>true
  validates_length_of :author,:title, :maximum => 300
end
